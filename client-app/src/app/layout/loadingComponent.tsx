import * as React from "react";
import { Dimmer, Loader } from "semantic-ui-react";

interface Props {
  inverterd?: boolean;
  content?: string;
}

export default function LoadingComponent({
  inverterd = true,
  content = "Loading...",
}: Props) {
  return (
    <Dimmer active={true} inverted={inverterd}>
      <Loader content={content} />
    </Dimmer>
  );
}
